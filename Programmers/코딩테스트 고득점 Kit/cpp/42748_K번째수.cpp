#include<bits/stdc++.h>

#define EL "\n";

using namespace std;

vector<int> solution(vector<int> array, vector<vector<int>> commands) {
    vector<int> answer;
	for (int command = 0; command < commands.size(); command++)
	{
		int i = commands[command][0]-1;
		int j = commands[command][1]-1;
		int k = commands[command][2]-1;

		vector<int> temp;

		for (int idx = i; idx <= j; idx++) {
			temp.push_back(array[idx]);
		}

		sort(temp.begin(), temp.end());

		answer.push_back(temp[k]);
	}
    
    return answer;
}

int main() {
	vector<int> v1;
	vector<vector<int>> v2;

	v1 = { 1, 5, 2, 6, 3, 7, 4 };
	v2 = { {2, 5, 3 }, {4, 4, 1}, {1, 7, 3} };

	vector<int> v3 = solution(v1, v2);

	for (int i = 0; i < v3.size(); i++) {
		cout << v3[i] << ' ';
	}

	return 0;
}