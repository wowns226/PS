#include <bits/stdc++.h>

#define FASTIO                             \
    std::ios_base::sync_with_stdio(false); \
    std::cin.tie(0);                       \
    std::cout.tie(0)
#define ENDL '\n'

/***************************************************************************************
 *   * 링크 : https://school.programmers.co.kr/learn/courses/30/lessons/12909
 ***************************************************************************************/

using namespace std;
bool solution(string s) {
    if (s.front() == ')' || s.back() == '(') {
        return false;
    }

    stack<char> st;
    for (int i = 0; i < s.size(); i++) {
        if (s[i] == '(') {
            st.push('(');
        } else {  // s[i]==')'
            if (st.top() == '(') {
                st.pop();
            }
        }
    }

    if (st.empty()) {
        return true;
    } else {
        return false;
    }
}

int main() {
    FASTIO;
    vector<string> v;
    v.push_back("()()");
    v.push_back("(())()");
    v.push_back(")()(");
    v.push_back("(()(");
    int test = 4;
    for (int i = 0; i < v.size(); i++) {
        cout << solution(v[i]) << ENDL;
    }
    return 0;
}
