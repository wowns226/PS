#include <bits/stdc++.h>

#define FASTIO                             \
    std::ios_base::sync_with_stdio(false); \
    std::cin.tie(0);                       \
    std::cout.tie(0)
#define ENDL '\n'

using namespace std;

int main() {
    FASTIO;

    int n, result = 0;
    cin >> n;
    while (n--) {
        int temp, cnt = 0;
        cin >> temp;
        for (int i = 1; i <= temp; i++) {
            if (temp % i == 0) cnt++;
        }

        if (cnt == 2) result++;
    }

    cout << result << ENDL;

    return 0;
}