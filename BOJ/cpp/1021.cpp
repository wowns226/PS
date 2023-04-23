#include <bits/stdc++.h>

#define FASTIO                             \
    std::ios_base::sync_with_stdio(false); \
    std::cin.tie(0);                       \
    std::cout.tie(0)
#define ENDL '\n'

using namespace std;

int main() {
    FASTIO;

    int n, m, temp, left, right;
    int cnt = 0;
    deque<int> dq;

    cin >> n >> m;
    for (int i = 1; i <= n; i++) {
        dq.push_back(i);
    }

    while (m--) {
        int tmp;
        cin >> tmp;

        for (int i = 0; i < dq.size(); i++) {
            if (dq[i] == tmp) {
                left = i;
                right = dq.size() - i;
                break;
            }
        }

        if (left <= right) {
            while (1) {
                if (dq.front() == tmp) break;

                dq.push_back(dq.front());
                dq.pop_front();
                cnt++;
            }
            dq.pop_front();
        } else {
            cnt++;
            while (1) {
                if (dq.back() == tmp) break;

                dq.push_front(dq.back());
                dq.pop_back();
                cnt++;
            }
            dq.pop_back();
        }
    }

    cout << cnt;

    return 0;
}
