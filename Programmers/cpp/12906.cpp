#include <bits/stdc++.h>

#define FASTIO                             \
    std::ios_base::sync_with_stdio(false); \
    std::cin.tie(0);                       \
    std::cout.tie(0)
#define ENDL '\n'

/***************************************************************************************
 *   * 링크 : https://school.programmers.co.kr/learn/courses/30/lessons/12906
 ***************************************************************************************/

using namespace std;

vector<int> solution(vector<int> arr) {
    vector<int> answer;

    // * Queue 사용
    // queue<int> q;
    // for (int i = 0; i < arr.size(); i++) {
    //     q.push(arr[i]);
    // }
    // int tmp = q.front();
    // q.pop();
    // answer.push_back(tmp);
    // while (!q.empty()) {
    //     tmp = q.front();
    //     q.pop();
    //     if (tmp == answer.back()) continue;
    //     answer.push_back(tmp);
    // }

    // unique : 중복 제거 함수
    // arr : 1 1 3 3 0 1 1
    // unique를 사용한 후의 arr
    // 1 3 0 1 0 1 1
    // 중복 숫자는 사라지고 기존 벡터 배열의 나머지 자리에 기존 벡터 배열 원소의 값이 채워짐
    // erase 함수를 활용하여 0 1 1 을 삭제
    arr.erase(unique(arr.begin(), arr.end()), arr.end());
    answer = arr;

    return answer;
}

int main() {
    FASTIO;

    vector<int> v;

    v.push_back(1);
    v.push_back(1);
    v.push_back(3);
    v.push_back(3);
    v.push_back(0);
    v.push_back(1);
    v.push_back(1);

    solution(v);

    return 0;
}
