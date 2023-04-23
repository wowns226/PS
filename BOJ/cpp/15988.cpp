#include <bits/stdc++.h>

#define FASTIO                             \
    std::ios_base::sync_with_stdio(false); \
    std::cin.tie(0);                       \
    std::cout.tie(0)
#define ENDL '\n'
#define ll long long

/***************************************************************************************
 *   * 링크 : https://www.acmicpc.net/problem/15988
 ***************************************************************************************/

// 내가 생각한 점화식 : dp[n+3] = dp[n+2] + dp[n+1] + dp[n]

using namespace std;

int t;
ll dp[1000001];

int main() {
    FASTIO;

    dp[0] = 1;
    dp[1] = 2;
    dp[2] = 4;

    for (int i = 3; i < 1000000; i++) {
        dp[i] = (dp[i - 1] + dp[i - 2] + dp[i - 3]) % 1000000009;
    }

    cin >> t;
    for (int i = 0; i < t; i++) {
        int n;
        cin >> n;
        cout << dp[n - 1] << ENDL;
    }

    return 0;
}
