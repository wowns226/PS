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
    int a, b;
    a = n / 5;
    while (true) {
        if (a < 0) {
            cout << "-1" << ENDL;
            return 0;
        }
        if ((n - (5 * a)) % 3 == 0) {
            b = (n - (5 * a)) / 3;
            break;
        }
        a--;
    }
    cout << a + b << ENDL;

    return 0;
}