#include <bits/stdc++.h>

#define FASTIO                             \
    std::ios_base::sync_with_stdio(false); \
    std::cin.tie(0);                       \
    std::cout.tie(0)
#define ENDL '\n'

/***************************************************************************************
 *   * 링크 : https://school.programmers.co.kr/learn/courses/30/lessons/42587
 ***************************************************************************************/

using namespace std;

int solution(vector<int> priorities, int location) {
    int answer = 0;
    queue<pair<int, int>> q;  // {인쇄 대기 목록, 인덱스}
    priority_queue<int> pq;   // 우선순위 인쇄 대기 목록

    for (int i = 0; i < size(priorities); i++) {
        q.push({priorities[i], i});
        pq.push(priorities[i]);
    }

    while (!q.empty()) {
        // 인쇄 대기 목록의 가장 앞에 있는 문서를 꺼냄
        auto cur = q.front();
        q.pop();

        // 가장 앞에 있는 문서가 우선순위 인쇄 대기 목록의 맨 앞과 일치하지 않으면
        if (cur.first != pq.top()) {
            // 우선순위 인쇄 대기 목록의 맨 뒤에 삽입
            q.push(cur);
        }
        // 일치하면
        else {
            // 인쇄
            pq.pop();
            answer++;

            // 내가 찾는 문서라면 해당 순서 반환
            if (cur.second == location) {
                break;
            }
        }
    }

    return answer;
}

int main() {
    FASTIO;
    vector<int> v;
    int location;

    v.push_back(2);
    v.push_back(1);
    v.push_back(3);
    v.push_back(2);
    location = 2;

    // v.push_back(1);
    // v.push_back(1);
    // v.push_back(9);
    // v.push_back(1);
    // v.push_back(1);
    // v.push_back(1);
    // location = 0;

    cout << solution(v, location) << ENDL;

    return 0;
}
