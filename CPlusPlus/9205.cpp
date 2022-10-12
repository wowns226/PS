#include <bits/stdc++.h>

#define FASTIO                             \
    std::ios_base::sync_with_stdio(false); \
    std::cin.tie(0);                       \
    std::cout.tie(0)
#define ENDL '\n'

/***************************************************************************************
 *   * 링크 : https://www.acmicpc.net/problem/9205
 ***************************************************************************************/

using namespace std;

struct Pos {
    int x;
    int y;
};

int t, n;
int board[102];
bool isVisited[102];

Pos startPoint, endPoint;
vector<Pos> storePoint;
queue<Pos> q;

// BFS 함수
void bfs() {
    memset(board, false, size(isVisited));
    memset(isVisited, false, size(isVisited));
    while (!q.empty()) {
        q.pop();
    }

    q.push(startPoint);

    while (!q.empty()) {
        auto cur = q.front();
        q.pop();

        if (abs(cur.x - endPoint.x) + abs(cur.y - endPoint.y) <= 1000) {
            cout << "happy" << ENDL;
            return;
        };

        for (int i = 0; i < n; i++) {
            if (isVisited[i]) continue;

            int d = abs(cur.x - storePoint[i].x) + abs(cur.y - storePoint[i].y);
            if (d <= 1000) {
                isVisited[i] = true;
                q.push(storePoint[i]);
            }
        }
    }

    cout << "sad" << ENDL;
    return;
}

int main() {
    FASTIO;

    cin >> t;

    while (t--) {
        storePoint.clear();
        while (!q.empty()) {
            q.pop();
        }

        cin >> n;
        int x, y;

        cin >> x >> y;
        startPoint = {x, y};
        q.push(startPoint);

        for (int i = 0; i < n; i++) {
            cin >> x >> y;
            storePoint.push_back({x, y});
        }

        cin >> x >> y;
        endPoint = {x, y};

        bfs();
    }

    return 0;
}
