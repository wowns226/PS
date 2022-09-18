#include <bits/stdc++.h>

#define FASTIO                             \
    std::ios_base::sync_with_stdio(false); \
    std::cin.tie(0);                       \
    std::cout.tie(0)
#define ENDL '\n'

/***************************************************************************************
 *   * 링크 : https://www.acmicpc.net/problem/15651
 ***************************************************************************************/

using namespace std;

const int MAX = 9;

int arr[MAX];
int isUsed[MAX];
int n, m;

void func(int k) {
    if (k == m) {
        for (int i = 0; i < m; i++) {
            cout << arr[i] << ' ';
        }
        cout << ENDL;
        return;
    }

    for (int i = 1; i <= n; i++) {
        if (isUsed[i] <= m) {
            arr[k] = i;
            isUsed[i]++;
            func(k + 1);
            isUsed[i]--;
        }
    }
}

int main() {
    FASTIO;
    cin >> n >> m;

    func(0);

    return 0;
}
