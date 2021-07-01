import { AppConfig } from '@app/shared/types/app-config.interface';
import { defaultLanguge } from './i18n.config'

export const AppConfiguration : AppConfig = {
    layoutType: 'vertical',
    sideNavCollapse: true,
    mobileNavCollapse: true,
    lang: defaultLanguge,
    navMenuColor: 'light',
    headerNavColor: '#ffffff'
}

// Change your API endpoint here
export const API_ENDPOINT = '/api'