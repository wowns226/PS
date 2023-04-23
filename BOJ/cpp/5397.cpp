#include <bits/stdc++.h>

#define FASTIO                             \
    std::ios_base::sync_with_stdio(false); \
    std::cin.tie(0);                       \
    std::cout.tie(0)
#define ENDL '\n'

/***************************************************************************************
 *   * 링크 : https://www.acmicpc.net/problem/5397
 ***************************************************************************************/
using namespace std;

int main() {
    FASTIO;

    int testCase;
    cin >> testCase;

    list<char> L;
    for (int i = 0; i < testCase; i++) {
        string s;
        cin >> s;

        auto cursor = L.begin();

        for (int j = 0; j < s.length(); j++) {
            if (s[j] == '<') {
                if (cursor != L.begin()) cursor--;
            } else if (s[j] == '>') {
                if (cursor != L.end()) cursor++;
            } else if (s[j] == '-') {
                if (cursor != L.begin()) {
                    cursor--;
                    cursor = L.erase(cursor);
                }
            } else {
                L.insert(cursor, s[j]);
            }
        }

        for (auto c : L) cout << c;

        s.clear();
        L.clear();

        cout << ENDL;
    }

    return 0;
}