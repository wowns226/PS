#include <bits/stdc++.h>

#define FASTIO                             \
    std::ios_base::sync_with_stdio(false); \
    std::cin.tie(0);                       \
    std::cout.tie(0)
#define ENDL '\n'

/***************************************************************************************
 *   * 링크 : https://www.acmicpc.net/problem/12852
 ***************************************************************************************/

using namespace std;

int n;
int dp[1000005];
int arr[1000005];

int main() {
    FASTIO;
    cin >> n;
    dp[1] = 0;
    for (int i = 2; i <= n; i++) {
        dp[i] = dp[i - 1] + 1;
        arr[i] = i - 1;

        if (i % 2 == 0 && dp[i] > dp[i / 2] + 1) {
            dp[i] = dp[i / 2] + 1;
            arr[i] = i / 2;
        }

        if (i % 3 == 0 && dp[i] > dp[i / 3] + 1) {
            dp[i] = dp[i / 3] + 1;
            arr[i] = i / 3;
        }
    }

    cout << dp[n] << ENDL;
    int cur = n;
    while (1) {
        cout << cur << ' ';
        if (cur == 1) break;
        cur = arr[cur];
    }

    return 0;
}
