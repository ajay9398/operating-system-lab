#include <stdio.h>
int main ()
{
   FILE *fp;
   int c;
   int len;
   fp = fopen("hi.txt","r");
   while(1)
    {
      c = fgetc(fp);
      if( feof(fp) )
        {
         break;
      }
      printf("%c", c);
   }
   fseek(fp, 0, SEEK_END);
   len = ftell(fp);
   fclose(fp);
   printf("\n\nTotal size of file = %d bytes\n", len);
    fclose(fp);
   return(0);
}
