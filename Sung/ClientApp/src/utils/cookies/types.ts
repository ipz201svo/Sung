import type { CookieSerializeOptions } from 'cookie';

export interface Cookies {
  get(name: string): string;
  set(name: string, value: string, options?: CookieSerializeOptions): void;
}