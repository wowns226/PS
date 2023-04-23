#include <bits/stdc++.h>

#define FASTIO                             \
    std::ios_base::sync_with_stdio(false); \
    std::cin.tie(0);                       \
    std::cout.tie(0)
#define ENDL '\n'

/***************************************************************************************
 *  * 링크 : https://www.acmicpc.net/problem/6603
 ***************************************************************************************/

using namespace std;

const int MAX = 15;

int k;
int arr[MAX];
bool isUsed[MAX];
vector<int> v;

void func(int n, int cnt) {
    if (cnt == 6) {
        for (int i = 0; i < 6; i++) {
            cout << arr[i] << ' ';
        }
        cout << ENDL;
        return;
    }

    for (int i = n; i < k; i++) {
        if (!isUsed[i]) {
            arr[cnt] = v[i];
            isUsed[i] = true;
            func(i, cnt + 1);
            isUsed[i] = false;
        }
    }
}

int main() {
    FASTIO;

    while (true) {
        cin >> k;
        if (k == 0) break;

        v.clear();
        v.resize(k);
        memset(arr, 0, sizeof(arr));
        memset(isUsed, false, sizeof(isUsed));

        for (int i = 0; i < k; i++) {
            cin >> v[i];
        }

        func(0, 0);
        cout << ENDL;
    }

    return 0;
}
