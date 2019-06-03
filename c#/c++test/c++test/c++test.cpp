#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <ctype.h>

#include <sys/queue.h>
#include <pthread.h>
#include <semaphore.h>


static LIST_HEAD(listhead, entry) head;
static FILE* fp;
struct listhead *headp = NULL;
int num_entries = 0;


static pthread_mutex_t lock_inputSplits = PTHREAD_MUTEX_INITIALIZER;

struct entry {
	char name[BUFSIZ];
	int frequency;
	LIST_ENTRY(entry) entries;
};

char* InputSplits(char* buf) {
	pthread_mutex_lock(&lock_inputSplits);
	fgets(buf, 4096, fp);
	pthread_mutex_unlock(&lock_inputSplits);
	return buf;
}

void* Mapping() {
	char buf[4096];
	buf = InputSplits(&buf);
	printf("%s", buf);
}

int main(int argc, char** argv)
{
	if (argc != 2) {
		fprintf(stderr, "%s: not enough input\n", argv[0]);
		exit(1);
	}

	fp = fopen(argv[1], "r");

	pthread_t tid[4];
	for (int i = 0; i < 4; ++i) {
		pthread_create(&tid[i], NULL, Mapping, NULL);
	}
}