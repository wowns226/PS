#include <bits/stdc++.h>

#define FASTIO                             \
    std::ios_base::sync_with_stdio(false); \
    std::cin.tie(0);                       \
    std::cout.tie(0)
#define ENDL '\n'

/***************************************************************************************
 *   * 링크 : https://www.acmicpc.net/problem/1260
 ***************************************************************************************/

using namespace std;

const int MAX = 1001;

int N, M, V;
int arr[MAX][MAX];
bool dfsvisited[MAX];
bool bfsvisited[MAX];

void DFS(int start) {
    cout << start << ' ';
    dfsvisited[start] = true;

    for (int i = 0; i < N + 1; i++) {
        if (arr[start][i] == 0) continue;
        if (dfsvisited[i]) continue;

        DFS(i);
    }
}

void BFS(int start) {
    queue<int> q;
    q.push(start);
    bfsvisited[start] = true;

    while (!q.empty()) {
        int now = q.front();
        q.pop();
        cout << now << ' ';

        for (int i = 0; i < N + 1; i++) {
            if (arr[now][i] == 0) continue;
            if (bfsvisited[i]) continue;

            q.push(i);
            bfsvisited[i] = true;
        }
    }
}

int main() {
    FASTIO;

    cin >> N >> M >> V;

    for (int i = 0; i < M; i++) {
        int row, cal;
        cin >> row >> cal;

        arr[row][cal] = 1;
        arr[cal][row] = 1;
    }

    DFS(V);
    cout << ENDL;
    BFS(V);

    return 0;
}
