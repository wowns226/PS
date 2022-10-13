#include <bits/stdc++.h>

#define FASTIO                             \
    std::ios_base::sync_with_stdio(false); \
    std::cin.tie(0);                       \
    std::cout.tie(0)
#define ENDL '\n'

/***************************************************************************************
 *   * 링크 : https://www.acmicpc.net/problem/18312
 ***************************************************************************************/

using namespace std;

int n, k;

int main() {
    FASTIO;
    cin >> n >> k;

    int cnt = 0;
    for (int h = 0; h <= n; h++) {
        for (int m = 0; m < 60; m++) {
            for (int s = 0; s < 60; s++) {
                if (h % 10 == k || h / 10 == k || m % 10 == k || m / 10 == k || s % 10 == k || s / 10 == k) {
                    cnt++;
                }
            }
        }
    }

    cout << cnt << ENDL;

    return 0;
}
