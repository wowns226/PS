#include <bits/stdc++.h>

#define FASTIO                             \
    std::ios_base::sync_with_stdio(false); \
    std::cin.tie(0);                       \
    std::cout.tie(0)
#define ENDL '\n'

using namespace std;

int main() {
    FASTIO;

    int maxLength = 0;
    vector<string> st;
    string answer;

    for (int i = 0; i < 5; i++) {
        string temp;
        cin >> temp;
        st.push_back(temp);

        if (maxLength < temp.size()) maxLength = temp.size();
    }

    for (int i = 0; i < maxLength; i++) {
        for (int j = 0; j < 5; j++) {
            if (st[j].size() <= i) continue;

            answer += st[j][i];
        }
    }

    cout << answer;

    return 0;
}