#include <bits/stdc++.h>

#define FASTIO                             \
    std::ios_base::sync_with_stdio(false); \
    std::cin.tie(0);                       \
    std::cout.tie(0)
#define ENDL '\n'

using namespace std;

int main() {
    FASTIO;

    int n;
    cin >> n;
    while (n--) {
        string s;
        cin >> s;

        cout << s.front();
        cout << s.back();
        cout << ENDL;
    }

    return 0;
}