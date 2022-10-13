#include <bits/stdc++.h>

#define FASTIO                             \
    std::ios_base::sync_with_stdio(false); \
    std::cin.tie(0);                       \
    std::cout.tie(0)
#define ENDL '\n'

/***************************************************************************************
 *   * 링크 : https://www.acmicpc.net/problem/11725
 ***************************************************************************************/

using namespace std;

int n, x, y;

int arr[100002];
bool visited[100002];
vector<int> v[100002];

void dfs(int _idx) {
    visited[_idx] = true;

    for (int i = 0; i < v[_idx].size(); i++) {
        int next = v[_idx][i];

        if (!visited[next]) {
            arr[next] = _idx;
            dfs(next);
        }
    }
}

int main() {
    FASTIO;
    cin >> n;
    for (int i = 0; i < n - 1; i++) {
        cin >> x >> y;

        v[x].push_back(y);
        v[y].push_back(x);
    }

    dfs(1);

    for (int i = 2; i <= n; i++) {
        cout << arr[i] << ENDL;
    }

    return 0;
}
