#include <cstdio>
#include <algorithm>

char t[111];
int r[111];

bool ee[1234567];

int main() {
	int n;
	scanf("%d", &n);
	for (int i = 0; i < n; ++i) scanf(" %c%d", t + i, r + i);
	int now = 0;
	for (int i = 0; i < n; ++i) {
		if (t[i] == '+') {
			ee[r[i]] = true;
		}
		else {
			if (ee[r[i]]) {
				ee[r[i]] = false;
			}
			else {
				++now;
			}
		}
	}
	std::fill(ee, ee + 1234567, 0);
	int ans = now;
	for (int i = 0; i < n; ++i) {
		if (t[i] == '+') {
			ee[r[i]] = true;
			++now;
		}
		else {
			ee[r[i]] = false;
			--now;
		}
		ans = std::max(ans, now);
	}
	printf("%d\n", ans);
}