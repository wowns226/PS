#include <bits/stdc++.h>

#define FASTIO                             \
    std::ios_base::sync_with_stdio(false); \
    std::cin.tie(0);                       \
    std::cout.tie(0)
#define ENDL '\n'

/***************************************************************************************
 *   * 링크 : https://www.acmicpc.net/problem/1874
 *   1. tmp라는 변수를 입력받아 1부터 tmp까지 stack에 push하다가 tmp라는 수를
 *   vector에 push_back
 *   2. 다음 tmp를 입력받아 stack의 top이랑 비교 후 같으면 vector에 push_back
 *   3. 아니라면 stack에 담았던 수의 다음수부터 다시 계산
 ***************************************************************************************/
using namespace std;

int main() {
    FASTIO;

    stack<int> snum;
    vector<char> vanswer;

    int N, cnt = 1;
    cin >> N;

    for (int i = 0; i < N; i++) {
        int tmp;
        cin >> tmp;

        while (cnt <= tmp) {
            snum.push(cnt);
            cnt++;
            vanswer.push_back('+');
        }

        if (snum.top() == tmp) {
            snum.pop();
            vanswer.push_back('-');
        } else {
            cout << "NO" << endl;
            return 0;
        }
    }

    for (int i = 0; i < vanswer.size(); i++) {
        cout << vanswer[i] << ENDL;
    }

    return 0;
}