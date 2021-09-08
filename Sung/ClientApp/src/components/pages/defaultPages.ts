import home from '../objects/home';

export const defaultPages = {
  home,
};

export type defaultPagesType = ReturnType<
  | typeof home
>;
