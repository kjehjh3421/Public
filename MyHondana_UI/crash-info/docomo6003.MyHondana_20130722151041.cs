S/W Version Information
Model: SGH-N055
Tizen-Version: 2.2.0
Build-Number: N055OMEAMG3
Build-Date: 2013.07.16 04:12:03

Crash Information
Process Name: MyHondana
PID: 17723
Date: 2013-07-22 15:10:41(GMT+0900)
Executable File Path: /opt/apps/docomo6003/bin/MyHondana
This process is multi-thread process
pid=17723 tid=17723
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 17723, uid 5000)

Register Information
r0   = 0x00000044, r1   = 0x00000044
r2   = 0x00000100, r3   = 0xb46f89d0
r4   = 0xb41bef70, r5   = 0x00000044
r6   = 0x01699950, r7   = 0x015db918
r8   = 0xa00009cb, r9   = 0xbecda88c
r10  = 0x00000001, fp   = 0xbecda708
ip   = 0xb41c0ed8, sp   = 0xbecda278
lr   = 0xb3b3472d, pc   = 0xb3b51188
cpsr = 0x280f0030

Memory Information
MemTotal:  2063908 KB
MemFree:   1231332 KB
Buffers:     48908 KB
Cached:     340136 KB
VmPeak:     213596 KB
VmSize:     164516 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       98004 KB
VmRSS:       98004 KB
VmData:      60988 KB
VmStk:         136 KB
VmExe:          32 KB
VmLib:       66904 KB
VmPTE:         190 KB
VmSwap:          0 KB

Maps Information
00008000 00010000 r-xp /usr/bin/launchpad_preloading_preinitializing_daemon
00018000 00071000 rw-p [heap]
00071000 01903000 rw-p [heap]
af2d3000 af2d5000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
af929000 b0128000 rwxp [stack:17735]
b0399000 b03aa000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b03b3000 b03b8000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b052f000 b0533000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
b053c000 b0d3b000 rwxp [stack:17725]
b0d3b000 b0d41000 r-xp /usr/lib/libUMP.so
b0d49000 b0e97000 r-xp /usr/lib/r3p2/libMali.so
b0ea3000 b0ecc000 r-xp /usr/lib/evas/modules/engines/gl_x11/linux-gnueabi-armv7l-1.7.99/module.so
b0ed7000 b0ef5000 r-xp /usr/lib/osp/libtestbuddy.so.1.0
b1230000 b127c000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b1285000 b128a000 r-xp /usr/lib/libjson.so.0.0.1
b1292000 b1296000 r-xp /usr/lib/liblocation-pos-log.so
b129e000 b12b0000 r-xp /usr/lib/libmmfile_utils.so.0.0.0
b12b8000 b12ba000 r-xp /usr/lib/libmedia-hash.so.1.0.0
b12c2000 b12c7000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b12cf000 b12da000 r-xp /usr/lib/libdrm-trusted.so.0.0.53
b12e2000 b12e4000 r-xp /usr/lib/libmedia-svc-hash.so.1.0.0
b12ec000 b12f9000 r-xp /usr/lib/libdrm-client.so.0.0.91
b1302000 b130a000 r-xp /usr/lib/lib_SamsungRec_V03010.so
b132c000 b1363000 r-xp /usr/lib/libpulse.so.0.16.2
b136b000 b13cf000 r-xp /usr/lib/libasound.so.2.0.0
b13d9000 b13dc000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b13e5000 b13e9000 r-xp /usr/lib/libascenario-0.2.so.0.0.0
b13f2000 b140f000 r-xp /usr/lib/libavsysaudio.so.0.0.1
b1417000 b141c000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b1424000 b1451000 r-xp /usr/lib/libSLP-location.so.0.0.0
b145a000 b1463000 r-xp /usr/lib/libdownload-provider-interface.so.1.0.7
b146c000 b1470000 r-xp /usr/lib/libmmffile.so.0.0.0
b1478000 b1480000 r-xp /usr/lib/libmedia-utils.so.0.0.0
b1488000 b14a2000 r-xp /usr/lib/libmedia-thumbnail.so.1.0.0
b14aa000 b14c5000 r-xp /usr/lib/libmedia-service.so.1.0.0
b14cd000 b14d8000 r-xp /usr/lib/libmdm-common.so.1.0.38
b14e0000 b14ee000 r-xp /usr/lib/libbookmark-adaptor.so.0.2.7
b14f7000 b14fe000 r-xp /usr/lib/libenchant.so.1.6.1
b1506000 b1509000 r-xp /usr/lib/libcapi-telephony-network-info.so.0.1.9
b1512000 b151b000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.17
b1524000 b1528000 r-xp /usr/lib/libmmfsession.so.0.0.0
b1531000 b1540000 r-xp /usr/lib/libmmfsound.so.0.1.0
b1548000 b154d000 r-xp /usr/lib/libmemenv.so.1.1.0
b1555000 b1593000 r-xp /usr/lib/libleveldb.so.1.1.0
b159c000 b15c6000 r-xp /usr/lib/libgstaudio-0.10.so.0.25.0
b15cf000 b15d1000 r-xp /usr/lib/libsecfw.so
b15d9000 b15e2000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
b15ed000 b15fc000 r-xp /usr/lib/libgstvideo-0.10.so.0.25.0
b1604000 b161c000 r-xp /usr/lib/libgstpbutils-0.10.so.0.25.0
b161e000 b162b000 r-xp /usr/lib/libgstinterfaces-0.10.so.0.25.0
b1634000 b163d000 r-xp /usr/lib/libgstapp-0.10.so.0.25.0
b1645000 b1687000 r-xp /usr/lib/libgstbase-0.10.so.0.30.0
b1690000 b172c000 r-xp /usr/lib/libgstreamer-0.10.so.0.30.0
b1738000 b175d000 r-xp /usr/lib/libxslt.so.1.1.16
b1766000 b1768000 r-xp /usr/lib/libewebkit2-ext.so.1.0.2
b1770000 b1778000 r-xp /usr/lib/libui-gadget-1.so.0.1.0
b1780000 b178c000 r-xp /usr/lib/libcapi-location-manager.so.0.1.14
b1794000 b1797000 r-xp /usr/lib/libcapi-web-url-download.so.0.1.0
b179f000 b17a4000 r-xp /usr/lib/libcapi-media-metadata-extractor.so
b17ac000 b17d3000 r-xp /usr/lib/libcapi-content-media-content.so.0.2.71
b17db000 b17f1000 r-xp /usr/lib/osp/libosp-locations.so.1.2.1.0
b17fa000 b1838000 r-xp /usr/lib/libmdm.so.1.0.66
b1840000 b1855000 r-xp /usr/lib/libnetwork.so.0.0.0
b185d000 b1866000 r-xp /usr/lib/libcapi-web-favorites.so
b186e000 b2acc000 r-xp /usr/lib/libewebkit2.so.0.10.150.3
b2bbf000 b2c12000 r-xp /usr/lib/osp/libosp-content.so.1.2.2.0
b2c1b000 b2c32000 r-xp /usr/lib/libwifi-direct.so.0.0
b2c3a000 b2c42000 r-xp /usr/lib/libcapi-network-wifi.so.0.1.10
b2c4a000 b2c53000 r-xp /usr/lib/libcapi-network-tethering.so.0.1.0
b2c5c000 b2c67000 r-xp /usr/lib/libcapi-network-connection.so.0.1.13
b2c6f000 b2cdb000 r-xp /usr/lib/osp/libosp-web.so.1.2.2.0
b2ce8000 b2d9d000 r-xp /usr/lib/osp/libosp-net.so.1.2.2.0
b2daa000 b2dc4000 r-xp /usr/lib/osp/libosp-json.so.1.2.2.0
b2dcd000 b2deb000 r-xp /usr/lib/osp/libosp-image.so.1.2.2.0
b2dfa000 b2e04000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
b2e0c000 b2e76000 r-xp /opt/usr/apps/docomo6003/bin/MyHondana.exe
b2e82000 b2efe000 r-xp /usr/lib/libosp-env-config.so.SOVERSION
b2f06000 b2f96000 r-xp /usr/lib/libCOREGL.so.3.0
b2fa0000 b2fa3000 r-xp /usr/lib/libmm_ta.so.0.0.0
b2fab000 b2fb2000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b2fbb000 b2fca000 r-xp /usr/lib/libICE.so.6.3.0
b2fd4000 b2fd9000 r-xp /usr/lib/libSM.so.6.0.1
b2fe1000 b2fe2000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b2fea000 b2fec000 r-xp /usr/lib/libledplayer.so.0.1
b2ff4000 b2ffa000 r-xp /usr/lib/libxcb-render.so.0.0.0
b3002000 b3003000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b300c000 b3013000 r-xp /usr/lib/libGLESv2.so.2.0
b301b000 b3062000 r-xp /usr/lib/libtiff.so.5.1.0
b306d000 b3096000 r-xp /usr/lib/libturbojpeg.so
b30af000 b30b3000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b30bc000 b30c2000 r-xp /usr/lib/libgif.so.4.1.6
b30ca000 b30ec000 r-xp /usr/lib/libavutil.so.51.73.101
b30fb000 b3129000 r-xp /usr/lib/libswscale.so.2.1.101
b3132000 b3429000 r-xp /usr/lib/libavcodec.so.54.59.100
b3750000 b3769000 r-xp /usr/lib/libpng12.so.0.50.0
b3772000 b3779000 r-xp /usr/lib/libfeedback.so.0.1.4
b3782000 b3796000 r-xp /usr/lib/libtts.so
b379e000 b37a0000 r-xp /usr/lib/libEGL.so.1.4
b37a8000 b385f000 r-xp /usr/lib/libcairo.so.2.11200.12
b3869000 b3882000 r-xp /usr/lib/osp/libosp-image-core.so.1.2.2.0
b388c000 b3890000 r-xp /usr/lib/libss-client.so.1.0.0
b3899000 b389b000 r-xp /opt/usr/apps/docomo6003/bin/MyHondana
b38a3000 b4159000 r-xp /usr/lib/osp/libosp-uifw.so.1.2.2.0
b41c9000 b41d2000 r-xp /usr/lib/libslp_devman_plugin.so
b41db000 b41dd000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
b41e5000 b41e8000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
b41f0000 b41f3000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b41fb000 b4208000 r-xp /usr/lib/libmodem.so.0.0.0
b4210000 b4213000 r-xp /usr/lib/libdevice-node.so.0.1
b421b000 b422b000 r-xp /usr/lib/libaccounts-svc.so.0.2.71
b4233000 b4236000 r-xp /usr/lib/libcsc-feature.so.0.0.0
b423e000 b4242000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b424a000 b4250000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b4258000 b4259000 r-xp /usr/lib/libcapi-system-power.so.0.1.0
b4262000 b4265000 r-xp /usr/lib/libcapi-system-device.so.0.1.0
b426d000 b4270000 r-xp /usr/lib/libcapi-system-runtime-info.so.0.0.3
b4279000 b427c000 r-xp /usr/lib/libcapi-network-serial.so.0.0.8
b4284000 b4285000 r-xp /usr/lib/libcapi-content-mime-type.so.0.0.2
b428d000 b429b000 r-xp /usr/lib/libcapi-appfw-application.so.0.1.0
b42a4000 b42aa000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.1.0
b42b2000 b42d7000 r-xp /usr/lib/libSLP-tapi.so.0.0.0
b42df000 b42e2000 r-xp /usr/lib/libuuid.so.1.3.0
b42eb000 b42ff000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
b4308000 b4310000 r-xp /usr/lib/libminizip.so.1.0.0
b4318000 b4324000 r-xp /usr/lib/libmessage-port.so.1.2.2.0
b432d000 b434b000 r-xp /usr/lib/libpcre.so.0.0.1
b4353000 b4357000 r-xp /usr/lib/libheynoti.so.0.0.2
b435f000 b436d000 r-xp /usr/lib/libdeviced.so.0.1.0
b4375000 b4380000 r-xp /usr/lib/libcryptsvc.so.0.0.1
b438d000 b4393000 r-xp /usr/lib/libdevman.so.0.1
b439b000 b439f000 r-xp /usr/lib/libchromium.so.1.0
b43a7000 b43ae000 r-xp /usr/lib/libalarm.so.0.0.0
b43b6000 b43c0000 r-xp /usr/lib/libcapi-security-privilege-manager.so.0.0.3
b43c9000 b46db000 r-xp /usr/lib/osp/libosp-appfw.so.1.2.2.0
b4703000 b470d000 r-xp /lib/libnss_files-2.13.so
b471d000 b472d000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.4
b472e000 b4742000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b474a000 b4767000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b476f000 b4772000 r-xp /usr/lib/libiniparser.so.0
b477b000 b47ce000 r-xp /usr/lib/libsoup-2.4.so.1.5.0
b47d8000 b47ec000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b47f5000 b4806000 r-xp /usr/lib/libcom-core.so.0.0.1
b480e000 b4814000 r-xp /usr/lib/libappsvc.so.0.1.0
b481c000 b481e000 r-xp /usr/lib/libdri2.so.0.0.0
b4826000 b482e000 r-xp /usr/lib/libdrm.so.2.4.0
b4836000 b483a000 r-xp /usr/lib/libtbm.so.1.0.0
b4842000 b4845000 r-xp /usr/lib/libXv.so.1.0.0
b484d000 b485f000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b4868000 b4934000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b494a000 b4959000 r-xp /usr/lib/libnotification.so.0.1.0
b4961000 b4985000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
b498e000 b499e000 r-xp /lib/libresolv-2.13.so
b49a2000 b49a4000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
b49ac000 b4a84000 r-xp /usr/lib/libxml2.so.2.7.8
b4a91000 b4b6e000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
b4b79000 b4b7e000 r-xp /usr/lib/libcheck.so.0.0.0
b4b86000 b4b90000 r-xp /usr/lib/libspdy.so.0.0.0
b4b99000 b4cec000 r-xp /usr/lib/libcrypto.so.1.0.0
b4d0a000 b4d56000 r-xp /usr/lib/libssl.so.1.0.0
b4d62000 b4d90000 r-xp /usr/lib/libidn.so.11.5.44
b4d99000 b4da3000 r-xp /usr/lib/libcares.so.2.1.0
b4dab000 b4dc2000 r-xp /lib/libexpat.so.1.5.2
b4dcc000 b4df0000 r-xp /usr/lib/libicule.so.48.1
b4df9000 b4e07000 r-xp /usr/lib/libsf_common.so
b4e10000 b4eab000 r-xp /usr/lib/libstdc++.so.6.0.14
b4ebe000 b4ed6000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b4ed7000 b4eda000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
b4ee2000 b4ee6000 r-xp /usr/lib/libecore_ipc.so.1.7.99
b4eef000 b4ef4000 r-xp /usr/lib/libffi.so.5.0.10
b4efc000 b4efd000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
b4f05000 b4f0f000 r-xp /usr/lib/libXext.so.6.4.0
b4f18000 b4f1b000 r-xp /usr/lib/libXtst.so.6.1.0
b4f23000 b4f29000 r-xp /usr/lib/libXrender.so.1.3.0
b4f31000 b4f37000 r-xp /usr/lib/libXrandr.so.2.2.0
b4f3f000 b4f40000 r-xp /usr/lib/libXinerama.so.1.0.0
b4f49000 b4f52000 r-xp /usr/lib/libXi.so.6.1.0
b4f5a000 b4f5d000 r-xp /usr/lib/libXfixes.so.3.1.0
b4f65000 b4f67000 r-xp /usr/lib/libXgesture.so.7.0.0
b4f6f000 b4f70000 r-xp /usr/lib/libXdamage.so.1.1.0
b4f79000 b4f80000 r-xp /usr/lib/libXcursor.so.1.0.2
b4f88000 b4fab000 r-xp /usr/lib/libexif.so.12.3.3
b4fbf000 b4fc9000 r-xp /usr/lib/libethumb.so.1.7.99
b4fd1000 b5015000 r-xp /usr/lib/libsndfile.so.1.0.25
b5023000 b5025000 r-xp /usr/lib/libctxdata.so.0.0.0
b502d000 b503b000 r-xp /usr/lib/libremix.so.0.0.0
b5043000 b5044000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
b504c000 b5065000 r-xp /usr/lib/liblua-5.1.so
b506e000 b5075000 r-xp /usr/lib/libembryo.so.1.7.99
b507e000 b50be000 r-xp /usr/lib/libcurl.so.4.3.0
b50c7000 b5131000 r-xp /usr/lib/libpixman-1.so.0.28.2
b513e000 b5162000 r-xp /usr/lib/libfontconfig.so.1.5.0
b516b000 b51c7000 r-xp /usr/lib/libharfbuzz.so.0.907.0
b51d9000 b51ed000 r-xp /usr/lib/libfribidi.so.0.3.1
b51f5000 b524d000 r-xp /usr/lib/libfreetype.so.6.8.1
b5258000 b527c000 r-xp /usr/lib/libjpeg.so.8.0.2
b5294000 b52ab000 r-xp /lib/libz.so.1.2.5
b52b3000 b52bb000 r-xp /usr/lib/libemotion.so.1.7.99
b52c3000 b52c8000 r-xp /usr/lib/libecore_fb.so.1.7.99
b52d1000 b52df000 r-xp /usr/lib/libsensor.so.1.1.0
b52eb000 b52f1000 r-xp /usr/lib/libappcore-common.so.1.1
b52f9000 b52fb000 r-xp /usr/lib/libpowertop-wrapper.so.0.2.80
b5303000 b530e000 r-xp /usr/lib/libresourced.so.0.2.80
b5316000 b5319000 r-xp /usr/lib/libproc-stat.so.0.2.80
b6316000 b63fe000 r-xp /usr/lib/libicuuc.so.48.1
b640b000 b652b000 r-xp /usr/lib/libicui18n.so.48.1
b6539000 b653c000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b6544000 b654c000 r-xp /usr/lib/libvconf.so.0.2.45
b6554000 b655a000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6562000 b656e000 r-xp /usr/lib/libail.so.0.1.0
b6576000 b6581000 r-xp /usr/lib/libaul.so.0.1.0
b658a000 b65a1000 r-xp /usr/lib/libecore_input.so.1.7.99
b65bc000 b65d9000 r-xp /usr/lib/libecore_evas.so.1.7.99
b65e2000 b65e4000 r-xp /usr/lib/libXcomposite.so.1.0.0
b65ec000 b6620000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
b6629000 b6658000 r-xp /usr/lib/libecore_x.so.1.7.99
b6662000 b66a1000 r-xp /usr/lib/libeina.so.1.7.99
b66aa000 b66bf000 r-xp /usr/lib/libecore.so.1.7.99
b66d6000 b66f1000 r-xp /usr/lib/libecore_con.so.1.7.99
b66fa000 b66ff000 r-xp /usr/lib/libecore_imf.so.1.7.99
b6707000 b670f000 r-xp /usr/lib/libethumb_client.so.1.7.99
b6717000 b6720000 r-xp /usr/lib/libedbus.so.1.7.99
b6728000 b672a000 r-xp /usr/lib/libefreet_trash.so.1.7.99
b6732000 b6736000 r-xp /usr/lib/libefreet_mime.so.1.7.99
b673f000 b6755000 r-xp /usr/lib/libefreet.so.1.7.99
b675f000 b67bb000 r-xp /usr/lib/libedje.so.1.7.99
b67c5000 b6875000 r-xp /usr/lib/libevas.so.1.7.99
b688f000 b68a2000 r-xp /usr/lib/libeet.so.1.7.99
b68ab000 b6915000 r-xp /lib/libm-2.13.so
b691e000 b691f000 r-xp /usr/lib/libpmapi.so.1.2
b6927000 b692e000 r-xp /usr/lib/libutilX.so.1.1.0
b6936000 b6a58000 r-xp /usr/lib/libelementary.so.1.7.99
b6a6d000 b6a70000 r-xp /lib/libattr.so.1.1.0
b6a78000 b6a7a000 r-xp /usr/lib/libXau.so.6.0.0
b6a82000 b6a88000 r-xp /lib/librt-2.13.so
b6a91000 b6a99000 r-xp /lib/libcrypt-2.13.so
b6ac9000 b6acc000 r-xp /lib/libcap.so.2.21
b6ad4000 b6ad6000 r-xp /usr/lib/libiri.so
b6ade000 b6af3000 r-xp /usr/lib/libxcb.so.1.1.0
b6afb000 b6b06000 r-xp /lib/libunwind.so.8.0.1
b6b34000 b6c51000 r-xp /lib/libc-2.13.so
b6c5f000 b6c68000 r-xp /lib/libgcc_s-4.5.3.so.1
b6c70000 b6c9c000 r-xp /usr/lib/libdbus-1.so.3.7.2
b6ca5000 b6ca8000 r-xp /usr/lib/libbundle.so.0.1.22
b6cb0000 b6cb2000 r-xp /lib/libdl-2.13.so
b6cbb000 b6cbe000 r-xp /usr/lib/libsmack.so.1.0.0
b6cc6000 b6da0000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
b6da9000 b6dbd000 r-xp /lib/libpthread-2.13.so
b6dc9000 b6dce000 r-xp /usr/lib/libecore_file.so.1.7.99
b6dd6000 b6dde000 r-xp /usr/lib/libappcore-efl.so.1.1
b6de0000 b6de1000 r-xp /usr/lib/libdlog.so.0.0.0
b6dea000 b6e57000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6e61000 b6e6b000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6e73000 b6f59000 r-xp /usr/lib/libX11.so.6.3.0
b6f64000 b6f65000 r-xp /usr/local/lib/libcortex-strings.so.1.0.0
b6f6d000 b6f71000 r-xp /usr/lib/libsys-assert.so
b6f79000 b6f96000 r-xp /lib/ld-2.13.so
becbc000 becdd000 rwxp [stack]
becbc000 becdd000 rwxp [stack]
End of Maps Information

Callstack Information (PID:17723)
Call Stack Count: 48
 0: Tizen::Ui::_ControlImpl::GetFullScreenSizeInfo() + 0x53 (0xb3b51188) [/usr/lib/osp/libosp-uifw.so] + 0x2ae188
 1: Tizen::Ui::Container::AddControl(Tizen::Ui::Control*) + 0x1c (0xb3b3472d) [/usr/lib/osp/libosp-uifw.so] + 0x29172d
 2: MyHondanaDetailForm::SetListView() + 0x8e8 (0xb2e34a64) [/opt/apps/docomo6003/bin/MyHondana.exe] + 0x28a64
 3: MyHondanaDetailForm::OnInitializing() + 0xb4 (0xb2e33c14) [/opt/apps/docomo6003/bin/MyHondana.exe] + 0x27c14
 4: Tizen::Ui::_ControlImpl::OnAttachedToMainTree() + 0x22 (0xb3b51d37) [/usr/lib/osp/libosp-uifw.so] + 0x2aed37
 5: Tizen::Ui::Controls::_FormImpl::OnAttachedToMainTree() + 0x28 (0xb3d11479) [/usr/lib/osp/libosp-uifw.so] + 0x46e479
 6: Tizen::Ui::_Control::CallOnAttachedToMainTree(Tizen::Ui::_Control&) + 0xb2 (0xb3b3a3c3) [/usr/lib/osp/libosp-uifw.so] + 0x2973c3
 7: Tizen::Ui::_Control::EndAttaching(Tizen::Ui::_Control&) + 0xf2 (0xb3b3d567) [/usr/lib/osp/libosp-uifw.so] + 0x29a567
 8: Tizen::Ui::_Control::AttachChild(Tizen::Ui::_Control&) + 0x5a (0xb3b3ff6f) [/usr/lib/osp/libosp-uifw.so] + 0x29cf6f
 9: Tizen::Ui::_ContainerImpl::AddChild(Tizen::Ui::_ControlImpl*, bool) + 0xa4 (0xb3b5d241) [/usr/lib/osp/libosp-uifw.so] + 0x2ba241
10: Tizen::Ui::Container::AddControl(Tizen::Ui::Control*) + 0x26 (0xb3b34737) [/usr/lib/osp/libosp-uifw.so] + 0x291737
11: Tizen::Ui::Container::AddControl(Tizen::Ui::Control const&) + 0x6 (0xb3b347c3) [/usr/lib/osp/libosp-uifw.so] + 0x2917c3
End of Call Stack

Package Information
Package Name: docomo6003.MyHondana
Package ID : docomo6003
Version: 1.0.0
Package Type: tpk
App Name: d book MyShelf
App ID: docomo6003.MyHondana
Type: Application
Categories: (NULL)
