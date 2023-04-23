#include <bits/stdc++.h>

#define FASTIO                             \
    std::ios_base::sync_with_stdio(false); \
    std::cin.tie(0);                       \
    std::cout.tie(0)
#define ENDL '\n'

/***************************************************************************************
 *   * 링크 : https://www.acmicpc.net/problem/1003
 ***************************************************************************************/

using namespace std;

int t;
pair<int, int> arr[42];

int main() {
    FASTIO;
    cin >> t;
    arr[0] = {1, 0};
    arr[1] = {0, 1};

    for (int i = 2; i < 41; i++) {
        arr[i] = {arr[i - 1].first + arr[i - 2].first, arr[i - 1].second + arr[i - 2].second};
    }

    while (t--) {
        int fibo;
        cin >> fibo;

        cout << arr[fibo].first << ' ' << arr[fibo].second << ENDL;
    }

    return 0;
}
