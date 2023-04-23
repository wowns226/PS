#include <bits/stdc++.h>

#define FASTIO                             \
    std::ios_base::sync_with_stdio(false); \
    std::cin.tie(0);                       \
    std::cout.tie(0)
#define ENDL '\n'

using namespace std;

int main() {
    FASTIO;

    int a, b;
    string answer;

    while (true) {
        cin >> a >> b;

        if (a == 0 && b == 0) break;

        answer = a > b ? "Yes" : "No";
        cout << answer << ENDL;
    }

    return 0;
}