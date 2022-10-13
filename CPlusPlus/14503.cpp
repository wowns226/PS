#include <bits/stdc++.h>

#define FASTIO                             \
    std::ios_base::sync_with_stdio(false); \
    std::cin.tie(0);                       \
    std::cout.tie(0)
#define ENDL '\n'

/***************************************************************************************
 *   * 링크 : https://www.acmicpc.net/problem/14503
 ***************************************************************************************/

using namespace std;

int n, m, cnt = 0;
bool isDone = false;
int board[52][52];
bool visited[52][52];
int r, c, d;
// 북 동 남 서
int dx[4] = {-1, 0, 1, 0};
int dy[4] = {0, 1, 0, -1};

void dfs() {
    for (int i = 0; i < 4; i++) {
        int nd = (d + 3 - i) % 4;
        int nr = r + dx[nd];
        int nc = c + dy[nd];

        if (nr < 0 || nc < 0 || nr >= n || nc >= m) continue;
        if (board[nr][nc] == 0 && !visited[nr][nc]) {
            visited[nr][nc] = true;
            cnt++;

            r = nr;
            c = nc;
            d = nd;

            dfs();
        }
    }

    int bd = d > 1 ? d - 2 : d + 2;
    int br = r + dx[bd];
    int bc = c + dy[bd];

    if (br >= 0 && br <= n || bc >= 0 || bc <= m) {
        if (board[br][bc] == 0) {
            r = br;
            c = bc;
            dfs();
        } else {
            if (!isDone) {
                cout << cnt << ENDL;
                isDone = true;
            }
        }
    }
}

int main() {
    FASTIO;

    memset(visited, false, size(visited));
    cin >> n >> m;
    cin >> r >> c >> d;
    for (int x = 0; x < n; x++) {
        for (int y = 0; y < m; y++) {
            cin >> board[x][y];
        }
    }

    visited[r][c] = true;
    cnt++;

    dfs();

    return 0;
}
