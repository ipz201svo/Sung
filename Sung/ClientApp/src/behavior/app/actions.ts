export const APP_DESTROY = 'APP/DESTROY' as const;
export const destroyApp = () => ({ type: APP_DESTROY });

export type AppAction = ReturnType<
  | typeof destroyApp
>