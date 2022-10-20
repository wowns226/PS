#include <bits/stdc++.h>

#define FASTIO                             \
    std::ios_base::sync_with_stdio(false); \
    std::cin.tie(0);                       \
    std::cout.tie(0)
#define ENDL '\n'
#define ll long long

/***************************************************************************************
 *   * 링크 : https://www.acmicpc.net/problem/18311
 ***************************************************************************************/

using namespace std;

int n;
ll k;
bool isClear;
vector<int> v;

int main() {
    FASTIO;
    cin >> n >> k;

    for (int i = 0; i < n; i++) {
        int tmp;
        cin >> tmp;
        v.push_back(tmp);
    }

    // 처음부터 끝까지 해당값을 빼주기
    int cnt = 0;
    for (int i = 0; i < v.size(); i++) {
        k -= v[i];

        if (k < 0) {
            isClear = true;
            cnt = i + 1;
            break;
        }
    }

    // 아직 남아있으면 뒤에서부터 처음까지 다시 빼기
    if (!isClear) {
        for (int i = n - 1; i >= 0; i--) {
            k -= v[i];

            if (k < 0) {
                cnt = i + 1;
                break;
            }
        }
    }

    cout << cnt << ENDL;
    return 0;
}
