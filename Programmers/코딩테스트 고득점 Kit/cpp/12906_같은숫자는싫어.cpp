#include<bits/stdc++.h>

#define EL "\n";

using namespace std;

vector<int> solution(vector<int> arr)
{
	vector<int> answer;
	for (int i = 0; i < arr.size(); i++)
	{
		if (answer.empty()) {
			answer.push_back(arr[i]);
		}
		else {
			if (answer.back() != arr[i]) {
				answer.push_back(arr[i]);
			}
		}
	}

	return answer;
}

int main() {
	vector<int> v1,v2,v3,v4;

	v1 = { 1,1,3,3,0,1,1 };
	v2 = { 4,4,4,3,3 };

	v3 = solution(v1);
	v4 = solution(v2);
	
	for (int i = 0; i < v3.size(); i++) {
		cout << v3[i] << ' ';
	}

	cout << EL;

	for (int i = 0; i < v4.size(); i++) {
		cout << v4[i] << ' ';
	}

	return 0;
}