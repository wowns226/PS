#include <bits/stdc++.h>

#define FASTIO                             \
    std::ios_base::sync_with_stdio(false); \
    std::cin.tie(0);                       \
    std::cout.tie(0)
#define ENDL '\n'

/***************************************************************************************
 *   * 링크 : https://www.acmicpc.net/problem/11659
 ***************************************************************************************/

using namespace std;

int n, m, i, j;
int arr[100005];
int dp[100005];

int main() {
    FASTIO;
    cin >> n >> m;
    for (int idx = 1; idx <= n; idx++) {
        cin >> arr[idx];
        dp[idx] = dp[idx - 1] + arr[idx];
    }
    for (int idx = 0; idx < m; idx++) {
        cin >> i >> j;
        cout << dp[j] - dp[i - 1] << ENDL;
    }

    return 0;
}
