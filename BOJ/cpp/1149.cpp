#include <bits/stdc++.h>

#define FASTIO                             \
    std::ios_base::sync_with_stdio(false); \
    std::cin.tie(0);                       \
    std::cout.tie(0)
#define ENDL '\n'

/***************************************************************************************
 *   * 링크 : https://www.acmicpc.net/problem/1149
 ***************************************************************************************/

using namespace std;

int n;
int d[1005][3];
int rgb[1005][3];

int main() {
    FASTIO;
    cin >> n;
    for (int i = 1; i <= n; i++) {
        for (int col = 0; col < 3; col++) {
            cin >> rgb[i][col];
        }
    }

    d[1][0] = rgb[1][0];
    d[1][1] = rgb[1][1];
    d[1][2] = rgb[1][2];

    for (int i = 2; i <= n; i++) {
        d[i][0] = min(d[i - 1][1], d[i - 1][2]) + rgb[i][0];
        d[i][1] = min(d[i - 1][0], d[i - 1][2]) + rgb[i][1];
        d[i][2] = min(d[i - 1][0], d[i - 1][1]) + rgb[i][2];
    }

    cout << *min_element(d[n], d[n] + 3) << ENDL;

    return 0;
}
