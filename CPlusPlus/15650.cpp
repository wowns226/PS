#include <bits/stdc++.h>

#define FASTIO                             \
    std::ios_base::sync_with_stdio(false); \
    std::cin.tie(0);                       \
    std::cout.tie(0)
#define ENDL '\n'

/***************************************************************************************
 *   * 링크 : https://www.acmicpc.net/problem/15650
 ***************************************************************************************/

using namespace std;

const int MAX = 10;

int n, m;
int arr[MAX];
bool isUsed[MAX];

void func(int num, int cnt) {
    if (cnt == m) {
        for (int i = 0; i < m; i++) {
            cout << arr[i] << ' ';
        }
        cout << ENDL;
        return;
    }
    for (int i = num; i <= n; i++) {
        if (!isUsed[i]) {
            arr[cnt] = i;
            isUsed[i] = true;
            func(i + 1, cnt + 1);
            isUsed[i] = false;
        }
    }
}

int main() {
    FASTIO;

    cin >> n >> m;

    func(1, 0);

    return 0;
}
