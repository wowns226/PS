#include <bits/stdc++.h>

#define FASTIO                             \
    std::ios_base::sync_with_stdio(false); \
    std::cin.tie(0);                       \
    std::cout.tie(0)
#define ENDL '\n'

/***************************************************************************************
 *   * 링크 : https://www.acmicpc.net/problem/1913
 ***************************************************************************************/

using namespace std;

int n, k;
int board[1001][1001] = {
    0,
};
// 아래, 오, 위, 왼 순서
int dx[4] = {1, 0, -1, 0};
int dy[4] = {0, 1, 0, -1};
pair<int, int> kPos;

int main() {
    FASTIO;
    cin >> n >> k;

    /*
        1. 0,0부터 시작해서 아래 왼쪽 위 아래 순으로 cnt 저장
        2. 만약에 한바퀴 다 돌았으면 안쪽으로 진입
        3. 다시 1,1부터 시작해서 1,2번 반복
        4. 돌다가 k값일때 현재 좌표 저장
    */

    int startx = 0;
    int starty = 0;
    int rotation = n / 2;
    int cnt = n * n + 1;

    // 1
    for (int i = 0; i <= rotation; i++) {
        int curx = startx;
        int cury = starty;

        cnt--;
        board[curx][cury] = cnt;

        if (cnt == k) {
            kPos = {curx + 1, cury + 1};
        }

        for (int dir = 0; dir < 4;) {
            int nx = curx + dx[dir];
            int ny = cury + dy[dir];

            if (nx < 0 + i || nx >= n - i || ny < 0 + i || ny >= n - i) {
                dir++;
            } else {
                if (startx == nx && starty == ny) break;

                cnt--;
                board[nx][ny] = cnt;

                curx = nx;
                cury = ny;

                // 4
                if (cnt == k) {
                    kPos = {nx + 1, ny + 1};
                }
            }
        }

        startx += 1;
        starty += 1;
    }

    // 정답 출력
    for (int x = 0; x < n; x++) {
        for (int y = 0; y < n; y++) {
            cout << board[x][y] << ' ';
        }
        cout << ENDL;
    }
    cout << kPos.first << ' ' << kPos.second << ENDL;

    return 0;
}
