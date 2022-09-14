#include <bits/stdc++.h>

#define FASTIO                             \
    std::ios_base::sync_with_stdio(false); \
    std::cin.tie(0);                       \
    std::cout.tie(0)
#define ENDL "\n"

/***************************************************************************************
 *   * 링크 : https://www.acmicpc.net/problem/7562
 ***************************************************************************************/

using namespace std;

const int MAX = 302;

int board[MAX][MAX];
int dist[MAX][MAX];
pair<int, int> START, END;
int testCase, testMax;

int dx[8] = {1, 2, 2, 1, -1, -2, -2, -1};
int dy[8] = {2, 1, -1, -2, -2, -1, 1, 2};

int main() {
    FASTIO;

    cin >> testCase;

    for (int t = 0; t < testCase; t++) {
        queue<pair<int, int>> q;

        memset(board, 0, sizeof(board));
        memset(dist, 0, sizeof(dist));

        cin >> testMax;
        cin >> START.first >> START.second;
        cin >> END.first >> END.second;

        q.push(START);

        while (!q.empty()) {
            auto cur = q.front();

            if (cur == END) {
                cout << dist[cur.first][cur.second] << ENDL;
                break;
            }

            q.pop();

            for (int dir = 0; dir < 8; dir++) {
                int nx = cur.first + dx[dir];
                int ny = cur.second + dy[dir];

                if (nx < 0 || ny < 0 || nx >= testMax || ny >= testMax) continue;
                if (dist[nx][ny] != 0) continue;

                dist[nx][ny] = dist[cur.first][cur.second] + 1;
                q.push({nx, ny});
            }
        }
    }

    return 0;
}
