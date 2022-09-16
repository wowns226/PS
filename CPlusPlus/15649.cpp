#include <bits/stdc++.h>

#define FASTIO                             \
    std::ios_base::sync_with_stdio(false); \
    std::cin.tie(0);                       \
    std::cout.tie(0)
#define ENDL '\n'

/***************************************************************************************
 *   * 링크 : https://www.acmicpc.net/problem/15649
 ***************************************************************************************/

using namespace std;

const int MAX = 10;

int n, m;
int arr[MAX];
bool isUsed[MAX];

void func(int k) {
    if (k == m) {
        for (int i = 0; i < m; i++) {
            cout << arr[i] << ' ';
        }
        cout << ENDL;
        return;
    }

    for (int i = 1; i <= n; i++) {
        if (!isUsed[i]) {
            arr[k] = i;
            isUsed[i] = true;
            func(k + 1);
            isUsed[i] = false;
        }
    }
}

int main() {
    FASTIO;

    cin >> n >> m;
    func(0);

    return 0;
}
