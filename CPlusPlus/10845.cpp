#include <bits/stdc++.h>

#define FASTIO                                                                 \
    std::ios_base::sync_with_stdio(false);                                     \
    std::cin.tie(0);                                                           \
    std::cout.tie(0);
#define ENDL "\n";

/***************************************************************************************
 *   * 링크 : https://www.acmicpc.net/problem/10845
 ***************************************************************************************/
using namespace std;

int main() {
    FASTIO

    queue<int> q;
    int TestCase;
    cin >> TestCase;

    for (int i = 0; i < TestCase; i++) {
        string s;
        cin >> s;
        if (s == "push") {
            int temp;
            cin >> temp;
            q.push(temp);
        } else if (s == "pop") {
            if (q.empty()) {
                cout << "-1" << ENDL;
            } else {
                cout << q.front() << ENDL;
                q.pop();
            }
        } else if (s == "size") {
            cout << q.size() << ENDL;
        } else if (s == "empty") {
            if (q.empty()) {
                cout << "1" << ENDL;
            } else {
                cout << "0" << ENDL;
            }
        } else if (s == "front") {
            if (q.empty()) {
                cout << "-1" << ENDL;
            } else {
                cout << q.front() << ENDL;
            }
        } else if (s == "back") {
            if (q.empty()) {
                cout << "-1" << ENDL;
            } else {
                cout << q.back() << ENDL;
            }
        }
    }

    return 0;
}