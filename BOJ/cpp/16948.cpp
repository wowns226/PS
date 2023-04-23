#include <bits/stdc++.h>

#define FASTIO                             \
    std::ios_base::sync_with_stdio(false); \
    std::cin.tie(0);                       \
    std::cout.tie(0)
#define ENDL '\n'

/***************************************************************************************
 *   * 링크 : https://www.acmicpc.net/problem/16948
 ***************************************************************************************/

using namespace std;

int board[202][202];
bool isVisited[202][202];
int r1, c1, r2, c2, n;
queue<pair<int, int>> q;
int dx[6] = {-2, -2, 0, 0, 2, 2};
int dy[6] = {-1, 1, -2, 2, -1, 1};

int main() {
    FASTIO;
    memset(board, -1, sizeof(board));

    cin >> n >> r1 >> c1 >> r2 >> c2;

    pair<int, int> target = {r2, c2};

    q.push({r1, c1});
    board[r1][c1] = 0;
    isVisited[r1][c1] = true;

    while (!q.empty()) {
        auto cur = q.front();
        q.pop();

        if (cur == target) {
            break;
        }

        for (int dir = 0; dir < 6; dir++) {
            int nx = cur.first + dx[dir];
            int ny = cur.second + dy[dir];

            if (nx < 0 || ny < 0 || nx >= n || ny >= n) continue;
            if (board[nx][ny] != -1 || isVisited[nx][ny]) continue;

            board[nx][ny] = board[cur.first][cur.second] + 1;
            isVisited[nx][ny] = true;
            q.push({nx, ny});
        }
    }

    cout << board[target.first][target.second] << ENDL;

    return 0;
}
