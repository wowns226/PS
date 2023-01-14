#include <bits/stdc++.h>

#define FASTIO                             \
    std::ios_base::sync_with_stdio(false); \
    std::cin.tie(0);                       \
    std::cout.tie(0)
#define ENDL '\n'

using namespace std;

int main() {
    FASTIO;

    vector<int> v;
    while (true) {
        for (int i = 0; i < 3; i++) {
            int temp;
            cin >> temp;
            v.push_back(temp);
        }

        if (v[0] == 0 && v[1] == 0 && v[2] == 0) break;

        sort(v.begin(), v.end());

        if (v[0] * v[0] + v[1] * v[1] == v[2] * v[2]) {
            cout << "right" << ENDL;
        } else {
            cout << "wrong" << ENDL;
        }

        v.clear();
    }

    return 0;
}