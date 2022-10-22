#include <bits/stdc++.h>

#define FASTIO                             \
    std::ios_base::sync_with_stdio(false); \
    std::cin.tie(0);                       \
    std::cout.tie(0)
#define ENDL '\n'

/***************************************************************************************
 *   * 링크 : https://www.acmicpc.net/problem/18512
 ***************************************************************************************/

using namespace std;

int x, y, p1, p2;

int main() {
    FASTIO;
    cin >> x >> y >> p1 >> p2;
    for (int i = 0; i < 100; i++) {
        if (p1 > p2) {
            p2 += y;
        } else if (p1 < p2) {
            p1 += x;
        } else {
            // p1 == p2
            cout << p1 << ENDL;
            return 0;
        }
    }

    cout << -1 << ENDL;
    return 0;
}
