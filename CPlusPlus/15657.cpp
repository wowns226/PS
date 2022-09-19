#include <bits/stdc++.h>

#define FASTIO                             \
    std::ios_base::sync_with_stdio(false); \
    std::cin.tie(0);                       \
    std::cout.tie(0)
#define ENDL "\n"

/***************************************************************************************
 *   * 링크 : https://www.acmicpc.net/problem/15657
 ***************************************************************************************/

using namespace std;

const int MAX = 50;

int n, m;
int arr[MAX];
bool isUsed[MAX];
vector<int> v;

void func(int k, int cnt) {
    if (cnt == m) {
        for (int i = 0; i < m; i++) {
            cout << arr[i] << ' ';
        }
        cout << ENDL;
        return;
    }

    for (int i = k; i < n; i++) {
        arr[cnt] = v[i];
        func(i, cnt + 1);
    }
}

int main() {
    FASTIO;
    cin >> n >> m;
    for (int i = 0; i < n; i++) {
        int tmp;
        cin >> tmp;
        v.push_back(tmp);
    }
    sort(v.begin(), v.end());
    func(0, 0);

    return 0;
}
