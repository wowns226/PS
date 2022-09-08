#include <bits/stdc++.h>

#define FASTIO                             \
    std::ios_base::sync_with_stdio(false); \
    std::cin.tie(0);                       \
    std::cout.tie(0);
#define ENDL "\n";

/***************************************************************************************
 *   * 링크 : https://www.acmicpc.net/problem/10866
 ***************************************************************************************/

using namespace std;

int main() {
    FASTIO

    deque<int> dq;

    int testCase, temp;
    cin >> testCase;

    for (int i = 0; i < testCase; i++) {
        string command;
        cin >> command;
        if (command == "push_front") {
            cin >> temp;
            dq.push_front(temp);
        } else if (command == "push_back") {
            cin >> temp;
            dq.push_back(temp);
        } else if (command == "pop_front") {
            if (dq.empty()) {
                cout << "-1" << ENDL;
            } else {
                temp = dq.front();
                cout << temp << ENDL;
                dq.pop_front();
            }
        } else if (command == "pop_back") {
            if (dq.empty()) {
                cout << "-1" << ENDL;
            } else {
                temp = dq.back();
                cout << temp << ENDL;
                dq.pop_back();
            }
        } else if (command == "size") {
            cout << dq.size() << ENDL;
        } else if (command == "empty") {
            if (dq.empty()) {
                cout << "1" << ENDL;
            } else {
                cout << "0" << ENDL;
            }
        } else if (command == "front") {
            if (dq.empty()) {
                cout << "-1" << ENDL;
            } else {
                cout << dq.front() << ENDL;
            }
        } else if (command == "back") {
            if (dq.empty()) {
                cout << "-1" << ENDL;
            } else {
                cout << dq.back() << ENDL;
            }
        }
    }

    return 0;
}