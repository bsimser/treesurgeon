/* 
  Copyright (c) 2002 Robert Rainwater
  Contributors: Justin Frankel, Fritz Elfert, and Amir Szekely

  This software is provided 'as-is', without any express or implied
  warranty.  In no event will the authors be held liable for any damages
  arising from the use of this software.

  Permission is granted to anyone to use this software for any purpose,
  including commercial applications, and to alter it and redistribute it
  freely, subject to the following restrictions:

  1. The origin of this software must not be misrepresented; you must not
     claim that you wrote the original software. If you use this software
     in a product, an acknowledgment in the product documentation would be
     appreciated but is not required.
  2. Altered source versions must be plainly marked as such, and must not be
     misrepresented as being the original software.
  3. This notice may not be removed or altered from any source distribution.

*/
#ifndef NOCLIB_H
#define NOCLIB_H

// kickik's clib methods
char *my_strstr(char *i, char *s);
char *my_strrchr(const char *string, int c);
void *my_memset(void *dest, int c, size_t count);

// iceman_k's clib methods
int lstrncmp(char *s1, const char *s2, int chars);
int lstrncmpi(char *s1, const char *s2, int chars);
#endif