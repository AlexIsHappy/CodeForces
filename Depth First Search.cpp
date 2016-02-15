#include <cmath>
#include <cstdio>
#include <vector>
#include <iostream>
#include <algorithm>
using namespace std;
int x[8] = { 0, 0, -1, 1, -1, -1, 1, 1 };
int y[8] = { -1, 1, 0, 0, -1, 1, -1, 1 };
int vis[15][15];
int arr[15][15];
int ans = 0;
void dfs(int a, int b)
{
	vis[a][b] = 1;
	ans++;
	for (int yy = 0; yy<8; yy++)
	{
		if (vis[x[yy] + a][y[yy] + b]) continue;
		if (arr[x[yy] + a][y[yy] + b] == 0) continue;
		dfs(x[yy] + a, y[yy] + b);
	}
}
int main() {
	int a, b; cin >> a >> b;
	for (int g = 1; g <= a; g++)
	{
		for (int y = 1; y <= b; y++) cin >> arr[g][y];
	}int answer = 0;
	for (int g = 1; g <= a; g++)
	{
		for (int y = 1; y <= b; y++)
		{
			if (vis[g][y]) continue;
			if (arr[g][y] == 0) continue;
			ans = 0;
			dfs(g, y);
			answer = max(answer, ans);
		}
	}
	cout << answer;
	return 0;
}
