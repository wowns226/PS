#include <bits/stdc++.h>

#define FASTIO                             \
    std::ios_base::sync_with_stdio(false); \
    std::cin.tie(0);                       \
    std::cout.tie(0)
#define ENDL '\n'

/***************************************************************************************
 *   * 링크 : https://www.acmicpc.net/problem/7576
 ***************************************************************************************/

using namespace std;

const int MAX = 1002;

int M, N;
int board[MAX][MAX];
int dist[MAX][MAX];
queue<pair<int, int>> q;
int dx[4] = {1, 0, -1, 0};
int dy[4] = {0, 1, 0, -1};

int main() {
    FASTIO;
    cin >> M >> N;

    for (int i = 0; i < N; i++) {
        for (int j = 0; j < M; j++) {
            cin >> board[i][j];

            if (board[i][j] == 1) q.push({i, j});
            if (board[i][j] == 0) dist[i][j] = -1;
        }
    }

    while (!q.empty()) {
        auto cur = q.front();
        q.pop();

        for (int dir = 0; dir < 4; dir++) {
            int nx = cur.first + dx[dir];
            int ny = cur.second + dy[dir];

            if (nx < 0 || nx >= N || ny < 0 || ny >= M) continue;
            if (dist[nx][ny] >= 0) continue;

            dist[nx][ny] = dist[cur.first][cur.second] + 1;
            q.push({nx, ny});
        }
    }

    int answer = 0;
    for (int i = 0; i < N; i++) {
        for (int j = 0; j < M; j++) {
            if (dist[i][j] == -1) {
                cout << "-1" << ENDL;
                return 0;
            }

            answer = max(answer, dist[i][j]);
        }
    }
    cout << answer << ENDL;

    return 0;
}
