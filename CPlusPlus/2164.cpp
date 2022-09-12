#include <bits/stdc++.h>

#define FASTIO                             \
    std::ios_base::sync_with_stdio(false); \
    std::cin.tie(0);                       \
    std::cout.tie(0);
#define ENDL "\n";

/***************************************************************************************
 *   * 링크 : https://www.acmicpc.net/problem/2164
 ***************************************************************************************/

using namespace std;

int main() {
    FASTIO

    queue<int> q;
    int testCase;
    cin >> testCase;

    for (int i = 1; i <= testCase; i++) {
        q.push(i);
    }

    while (q.size() > 1) {
        q.pop();

        int temp = q.front();
        q.pop();
        q.push(temp);
    }

    cout << q.front() << ENDL;

    return 0;
}