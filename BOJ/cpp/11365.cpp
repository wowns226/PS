#include <bits/stdc++.h>

#define FASTIO                             \
    std::ios_base::sync_with_stdio(false); \
    std::cin.tie(0);                       \
    std::cout.tie(0)
#define ENDL '\n'

/***************************************************************************************
 *   * 링크 : https://www.acmicpc.net/problem/11365
 ***************************************************************************************/

using namespace std;

int main() {
    FASTIO;

    while (true) {
        string s;
        getline(cin, s);

        if (s == "END") break;

        for (int i = s.length() - 1; i >= 0; i--) {
            cout << s[i];
        }

        cout << ENDL;
    }

    return 0;
}
