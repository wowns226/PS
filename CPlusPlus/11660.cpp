#include <bits/stdc++.h>

#define FASTIO                             \
    std::ios_base::sync_with_stdio(false); \
    std::cin.tie(0);                       \
    std::cout.tie(0)
#define ENDL '\n'

/***************************************************************************************
 *   * 링크 : https://www.acmicpc.net/problem/11660
 ***************************************************************************************/

using namespace std;

int n, m;
int board[1026][1026] = {
    0,
};
int dp[1026][1026] = {
    0,
};

int main() {
    FASTIO;
    cin >> n >> m;

    for (int x = 1; x <= n; x++) {
        for (int y = 1; y <= n; y++) {
            cin >> board[x][y];
            dp[x][y] = dp[x - 1][y] + dp[x][y - 1] - dp[x - 1][y - 1] + board[x][y];
        }
    }

    for (int i = 0; i < m; i++) {
        int answer = 0;
        int start_x, start_y, end_x, end_y;
        cin >> start_x >> start_y >> end_x >> end_y;

        answer = dp[end_x][end_y] - dp[start_x - 1][end_y] - dp[end_x][start_y - 1] + dp[start_x - 1][start_y - 1];
        cout << answer << ENDL;
    }

    return 0;
}
