#include <bits/stdc++.h>

#define EL "\n";

using namespace std;

int solution(vector<int> nums)
{
	int answer = 0;
	set<int> s;

	for (int i = 0; i < nums.size(); i++) {
		s.insert(nums[i]);
	}

	answer = min(s.size(), nums.size() / 2);

	return answer;
}

int main() {
	vector<int> v1,v2,v3;

	v1 = { 3,1,2,3 };
	v2 = { 3,3,3,2,2,4 };
	v3 = { 3,3,3,2,2,2 };

	cout << solution(v1) << EL;
	cout << solution(v2) << EL;
	cout << solution(v3) << EL;

    return 0;
}