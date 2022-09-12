#include <bits/stdc++.h>

#define FASTIO                             \
    std::ios_base::sync_with_stdio(false); \
    std::cin.tie(0);                       \
    std::cout.tie(0)
#define ENDL "\n"

/***************************************************************************************
 *   * 링크 : https://www.acmicpc.net/problem/1406
 ***************************************************************************************/

using namespace std;

int main() {
    FASTIO;

    list<char> ls;

    string s;
    cin >> s;

    for (auto c : s) ls.push_back(c);

    int testCase;
    cin >> testCase;

    auto cursor = ls.end();
    for (int i = 0; i < testCase; i++) {
        char cmd;
        cin >> cmd;
        if (cmd == 'L') {
            if (cursor != ls.begin()) cursor--;
        } else if (cmd == 'D') {
            if (cursor != ls.end()) cursor++;
        } else if (cmd == 'B') {
            if (cursor != ls.begin()) {
                cursor--;
                cursor = ls.erase(cursor);
            }
        } else if (cmd == 'P') {
            char alp;
            cin >> alp;
            ls.insert(cursor, alp);
        }
    }

    for (auto c : ls) cout << c;

    return 0;
}