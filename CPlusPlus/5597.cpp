#include <bits/stdc++.h>

#define FASTIO                             \
    std::ios_base::sync_with_stdio(false); \
    std::cin.tie(0);                       \
    std::cout.tie(0)
#define ENDL '\n'

/***************************************************************************************
 *   * 링크 : https://www.acmicpc.net/problem/5597
 ***************************************************************************************/

using namespace std;

int n;
bool arr[32];

int main() {
    FASTIO;
    for (int i = 0; i < 28; i++) {
        cin >> n;
        arr[n] = true;
    }

    for (int i = 1; i <= 30; i++) {
        if (!arr[i]) {
            cout << i << ENDL;
        }
    }

    return 0;
}
