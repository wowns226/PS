#include <bits/stdc++.h>

#define FASTIO                             \
    std::ios_base::sync_with_stdio(false); \
    std::cin.tie(0);                       \
    std::cout.tie(0)
#define ENDL '\n'

/***************************************************************************************
 *   * 링크 : https://www.acmicpc.net/problem/2579
 ***************************************************************************************/

using namespace std;

int n;
int stair[303];
int dp[303];

int main() {
    FASTIO;
    cin >> n;
    for (int i = 1; i <= n; i++) {
        cin >> stair[i];
    }
    dp[1] = stair[1];
    dp[2] = stair[1] + stair[2];
    dp[3] = max(stair[1] + stair[3], stair[2] + stair[3]);

    for (int i = 4; i <= n; i++) {
        dp[i] = max(dp[i - 2] + stair[i], dp[i - 3] + stair[i - 1] + stair[i]);
    }
    cout << dp[n] << ENDL;
    return 0;
}
