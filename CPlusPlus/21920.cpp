#include <bits/stdc++.h>

#define FASTIO                             \
    std::ios_base::sync_with_stdio(false); \
    std::cin.tie(0);                       \
    std::cout.tie(0)
#define ENDL '\n'

/***************************************************************************************
 *   * 링크 : https://www.acmicpc.net/problem/21920
 ***************************************************************************************/

using namespace std;

int n, x;
vector<int> answer;

// a와 b가 서로소인지 확인하여 서로소라면 a의 값을 아니라면 0을 return
int func(int a, int b) {
    if (b == 0) {
        return a;
    } else {
        return func(b, a % b);
    }
}

int main() {
    FASTIO;
    cin >> n;
    vector<int> v(n);
    for (int i = 0; i < n; i++) {
        cin >> v[i];
    }
    cin >> x;

    for (int i = 0; i < n; i++) {
        if (func(v[i], x) == 1) {
            answer.push_back(v[i]);
        }
    }

    double sum = 0;
    for (int i = 0; i < answer.size(); i++) {
        sum += answer[i];
    }

    double answerSize = answer.size();

    sum /= answerSize;

    // 오차 10^-6까지 표현
    cout.precision(7);
    cout << sum << ENDL;

    return 0;
}
