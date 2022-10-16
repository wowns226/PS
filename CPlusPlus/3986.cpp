#include <bits/stdc++.h>

#define FASTIO                             \
    std::ios_base::sync_with_stdio(false); \
    std::cin.tie(0);                       \
    std::cout.tie(0)
#define ENDL '\n'

/***************************************************************************************
 *   * 링크 : https://www.acmicpc.net/problem/3986
 ***************************************************************************************/

using namespace std;

int main() {
    FASTIO;
    int n;
    cin >> n;

    int cnt = 0;
    for (int i = 0; i < n; i++) {
        string st;
        cin >> st;
        stack<char> s;

        for (int j = 0; j < st.length(); j++) {
            if (!s.empty() && s.top() == st[j]) {
                s.pop();
                continue;
            }

            s.push(st[j]);
        }

        if (s.empty()) {
            cnt++;
        }
    }

    cout << cnt << ENDL;
    return 0;
}
