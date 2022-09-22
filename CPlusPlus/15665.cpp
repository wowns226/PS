#include <bits/stdc++.h>

#define FASTIO                             \
    std::ios_base::sync_with_stdio(false); \
    std::cin.tie(0);                       \
    std::cout.tie(0)
#define ENDL '\n'

/***************************************************************************************
 *   * 링크 : https://www.acmicpc.net/problem/15665
 ***************************************************************************************/

using namespace std;

const int MAX = 10;

int n, m;
int arr[MAX];
vector<int> v;

void func(int k, int cnt) {
    if (cnt == m) {
        for (int i = 0; i < m; i++) {
            cout << arr[i] << ' ';
        }
        cout << ENDL;
        return;
    }

    int tmp = 0;
    for (int i = 0; i < n; i++) {
        if (v[i] != tmp) {
            arr[cnt] = v[i];
            tmp = arr[cnt];
            func(i, cnt + 1);
        }
    }
}

int main() {
    FASTIO;
    cin >> n >> m;
    v.resize(n);
    for (int i = 0; i < n; i++) {
        cin >> v[i];
    }
    sort(v.begin(), v.end());
    func(0, 0);
    return 0;
}
