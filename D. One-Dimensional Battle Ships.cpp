#include <bits/stdc++.h>

#define pii pair<int, int>

#define pb push_back
#define mp make_pair

#define f first
#define s second

using namespace std;

typedef long long ll;
typedef unsigned long long ull;

const int INF = (int) 2e9 + 7;
const int MAXN = (int) 1e6 + 7;

int n, k, len;

int m;
int moves[MAXN];

int sum[MAXN];

bool check(int x) {
	for (int i = 1; i <= n; i++)
		sum[i] = 0;
	for (int i = 1; i <= x; i++)
		sum[moves[i]]++;
	for (int i = 1; i <= n; i++)
		sum[i] += sum[i - 1];
	int pos = 1;
	int placed = 0;
	while (pos <= n) {
		if (pos + len - 1 <= n && sum[pos + len - 1] - sum[pos - 1] == 0) {
			placed++;
			pos += len;
		}
		pos++;
	}
	return placed >= k;
}

int main() {
#ifdef LOCAL
	freopen("in", "r", stdin);
#endif // LOCAL

	scanf("%d%d%d", &n, &k, &len);
	scanf("%d", &m);
	for (int i = 1; i <= m; i++)
		scanf("%d", &moves[i]);

	int l = 0, r = m + 1;
	while (r - l > 1) {
		int mid = (l + r) / 2;
		if (check(mid))
			l = mid;
		else
			r = mid;
	}
	if (l == m)
		printf("-1");
	else
		printf("%d", l + 1);
	return 0;
}