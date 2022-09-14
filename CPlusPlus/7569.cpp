#include <bits/stdc++.h>

#define FASTIO                             \
    std::ios_base::sync_with_stdio(false); \
    std::cin.tie(0);                       \
    std::cout.tie(0)
#define ENDL "\n"

/***************************************************************************************
 *   * 링크 : https://www.acmicpc.net/problem/7569
 ***************************************************************************************/

using namespace std;

const int MAX = 102;

int dx[6] = {1, 0, 0, -1, 0, 0};
int dy[6] = {0, 1, 0, 0, -1, 0};
int dz[6] = {0, 0, 1, 0, 0, -1};
queue<pair<pair<int, int>, int>> q;
int M, N, H;
int board[MAX][MAX][MAX];
int dist[MAX][MAX][MAX];

int main() {
    FASTIO;

    cin >> M >> N >> H;

    for (int z = 0; z < H; z++) {
        for (int y = 0; y < N; y++) {
            for (int x = 0; x < M; x++) {
                cin >> board[x][y][z];

                if (board[x][y][z] == 1) {
                    q.push({{x, y}, z});
                }
                if (board[x][y][z] == 0) {
                    dist[x][y][z] = -1;
                }
            }
        }
    }

    while (!q.empty()) {
        auto cur = q.front();
        q.pop();

        for (int dir = 0; dir < 6; dir++) {
            int nx = cur.first.first + dx[dir];
            int ny = cur.first.second + dy[dir];
            int nz = cur.second + dz[dir];

            if (nx < 0 || ny < 0 || nz < 0 || nx >= M || ny >= N || nz >= H) continue;
            if (dist[nx][ny][nz] >= 0) continue;

            q.push({{nx, ny}, nz});
            dist[nx][ny][nz] = dist[cur.first.first][cur.first.second][cur.second] + 1;
        }
    }

    int answer = 0;
    for (int z = 0; z < H; z++) {
        for (int y = 0; y < N; y++) {
            for (int x = 0; x < M; x++) {
                if (dist[x][y][z] == -1) {
                    cout << "-1" << ENDL;
                    return 0;
                }

                answer = max(answer, dist[x][y][z]);
            }
        }
    }
    cout << answer << ENDL;

    return 0;
}
