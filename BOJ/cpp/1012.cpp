#include <bits/stdc++.h>

#define FASTIO                             \
    std::ios_base::sync_with_stdio(false); \
    std::cin.tie(0);                       \
    std::cout.tie(0)
#define ENDL '\n'

/***************************************************************************************
 *   * 링크 : https://www.acmicpc.net/problem/1012
 ***************************************************************************************/

using namespace std;

const int MAX = 52;

int dx[4] = {1, 0, -1, 0};
int dy[4] = {0, 1, 0, -1};
int M, N, K, testCase, x, y;

int main() {
    FASTIO;
    cin >> testCase;
    for (int i = 0; i < testCase; i++) {
        int board[MAX][MAX] = {
            0,
        };
        bool visited[MAX][MAX] = {
            false,
        };

        cin >> M >> N >> K;

        for (int j = 0; j < K; j++) {
            cin >> x >> y;

            board[x][y] = 1;
        }

        queue<pair<int, int>> q;

        int answer = 0;
        for (int m = 0; m < M; m++) {
            for (int n = 0; n < N; n++) {
                if (board[m][n] == 0 || visited[m][n]) continue;
                answer++;
                visited[m][n] = true;
                q.push({m, n});

                while (!q.empty()) {
                    auto cur = q.front();
                    q.pop();

                    for (int dir = 0; dir < 4; dir++) {
                        int nx = cur.first + dx[dir];
                        int ny = cur.second + dy[dir];

                        if (nx < 0 || nx >= M || ny < 0 || ny >= N) continue;
                        if (board[nx][ny] != 1 || visited[nx][ny]) continue;

                        visited[nx][ny] = true;
                        q.push({nx, ny});
                    }
                }
            }
        }
        cout << answer << ENDL;
    }

    return 0;
}
