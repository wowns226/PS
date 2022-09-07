//#include <bits/stdc++.h>
#include <iostream>
#include <stack>

#define FASTIO                             \
    std::ios_base::sync_with_stdio(false); \
    std::cin.tie(0);                       \
    std::cout.tie(0);
#define ENDL "\n";
#define LL long long

const int MAX = 80001;

/***************************************************************************************
 *   * 링크 : https://www.acmicpc.net/problem/6198
 ***************************************************************************************/

using namespace std;

int main() {
    FASTIO
    int N;
    cin >> N;

    int buildings[MAX];

    for (int i = 0; i < N; i++) {
        cin >> buildings[i];  // 10 3 7 4 12 2
    }

    stack<int> st;
    LL answer = 0;

    for (int i = 0; i < N; i++) {
        while (!st.empty() && st.top() <= buildings[i]) {
            st.pop();
        }

        st.push(buildings[i]);

        answer += st.size() - 1;
    }

    cout << answer << ENDL;

    return 0;
}