#include <bits/stdc++.h>

#define FASTIO                             \
    std::ios_base::sync_with_stdio(false); \
    std::cin.tie(0);                       \
    std::cout.tie(0)
#define ENDL "\n"

/***************************************************************************************
 *   * 링크 : https://www.acmicpc.net/problem/15652
 ***************************************************************************************/

using namespace std;

const int MAX = 10;

int arr[MAX];
int n, m;

void func(int k, int cnt) {
    if (cnt == m) {
        for (int i = 0; i < m; i++) {
            cout << arr[i] << ' ';
        }
        cout << ENDL;
        return;
    }

    for (int i = k; i <= n; i++) {
        arr[cnt] = i;
        func(i, cnt + 1);
    }
}

int main() {
    FASTIO;
    cin >> n >> m;
    func(1, 0);
    return 0;
}
